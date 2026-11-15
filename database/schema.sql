SET NAMES utf8mb4;

CREATE TABLE Expeditions (
    expedition_id INT AUTO_INCREMENT PRIMARY KEY,
    expedition_name VARCHAR(50) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    geographical_location VARCHAR(100) NOT NULL,
    research_goal TEXT NOT NULL,
    leader INT NOT NULL,  -- руководитель (не внешний ключ)
    stakeholder VARCHAR(100) NOT NULL,  -- источник финансирования
    budget DECIMAL(10, 2),
    CONSTRAINT chk_budget CHECK (budget >= 0)
);

CREATE TABLE Archaeological_Site_Objects (
    object_id INT AUTO_INCREMENT PRIMARY KEY,
    expedition_id INT NOT NULL,
    object_name VARCHAR(100) NOT NULL,
    location VARCHAR(100) NOT NULL,
    historical_significance TEXT,
    FOREIGN KEY (expedition_id) REFERENCES Expeditions(expedition_id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Findings (
    finding_id INT AUTO_INCREMENT PRIMARY KEY,
    object_id INT NOT NULL,
    description TEXT,
    finding_date DATE NOT NULL,
    status VARCHAR(50),  -- заменили 'condition' на 'status'
    FOREIGN KEY (object_id) REFERENCES Archaeological_Site_Objects(object_id) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT chk_status CHECK (status IN ('целая', 'поврежденная', 'на реставрации', 'не тронута'))

);

CREATE TABLE Specialties (
    specialty_id INT AUTO_INCREMENT PRIMARY KEY,
    specialty_name VARCHAR(100) NOT NULL UNIQUE,
    CONSTRAINT unique_specialty_name UNIQUE (specialty_name)  -- Уникальная специальность
);

CREATE TABLE Roles (
    role_id INT AUTO_INCREMENT PRIMARY KEY,
    role_name VARCHAR(100) NOT NULL UNIQUE,
    CONSTRAINT unique_role_name UNIQUE (role_name)  -- Уникальная роль
);

CREATE TABLE Research_Groups (
    group_id INT AUTO_INCREMENT PRIMARY KEY,
    expedition_id INT NOT NULL,
    group_name VARCHAR(100) NOT NULL,  -- название исследовательской группы
    leader INT NOT NULL,  -- руководитель группы (просто атрибут, не внешний ключ)
    tasks TEXT,
    FOREIGN KEY (expedition_id) REFERENCES Expeditions(expedition_id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Participation_in_Expedition (
    participation_id INT AUTO_INCREMENT PRIMARY KEY,
    group_id INT NOT NULL,
    specialist_id INT NOT NULL,
    role_id INT NOT NULL,
    FOREIGN KEY (group_id) REFERENCES Research_Groups(group_id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (role_id) REFERENCES Roles(role_id) ON UPDATE CASCADE ON DELETE CASCADE,  -- внешний ключ на таблицу Roles
    CONSTRAINT unique_participation UNIQUE (group_id, specialist_id)  -- Ограничение на уникальность участника в группе
);

CREATE TABLE Specialists (
    specialist_id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    specialty_id INT NOT NULL,  -- Reference to Specialties table
    participation_id INT NULL,  -- Adding participation_id as a foreign key
    FOREIGN KEY (specialty_id) REFERENCES Specialties(specialty_id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (participation_id) REFERENCES Participation_in_Expedition(participation_id) ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT unique_specialist_name UNIQUE (full_name)  -- Уникальное имя специалиста
);

CREATE TABLE Expenses (
    expense_id INT AUTO_INCREMENT PRIMARY KEY,
    expedition_id INT NOT NULL,
    amount DECIMAL(10, 2),
    description TEXT,
    expense_date DATE NOT NULL,
    FOREIGN KEY (expedition_id) REFERENCES Expeditions(expedition_id) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT chk_expense_amount CHECK (amount > 0)  -- сумма расхода больше 0
);

CREATE TABLE Users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,  -- Храните зашифрованные пароли
    role ENUM('admin', 'leader', 'specialist') NOT NULL
);

DELIMITER $$
CREATE TRIGGER check_budget_before_expense
BEFORE INSERT ON Expenses
FOR EACH ROW
BEGIN
    DECLARE remaining_budget DECIMAL(10, 2);
    SELECT e.budget - COALESCE((
        SELECT SUM(ex.amount) FROM Expenses ex
        WHERE ex.expedition_id = NEW.expedition_id
    ), 0)
    INTO remaining_budget
    FROM Expeditions e
    WHERE e.expedition_id = NEW.expedition_id;

    IF NEW.amount > remaining_budget THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Not enough budget for this expense';
    END IF;
END$$
DELIMITER ;
