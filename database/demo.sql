SET NAMES utf8mb4;

INSERT INTO Users (username, password, role) VALUES
    ('demo_admin', 'local-demo-only', 'admin');

INSERT INTO Specialties (specialty_name) VALUES ('Археология');

INSERT INTO Expeditions
    (expedition_name, start_date, end_date, geographical_location, research_goal, leader, stakeholder, budget)
VALUES
    ('Демонстрационная экспедиция', '2025-06-01', '2025-06-15', 'Учебный участок',
    'Учёт находок демонстрационного участка', 1, 'Учебный проект', 10000.00);
