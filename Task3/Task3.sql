CREATE TABLE Consultant (
    consultant_id INT PRIMARY KEY,
    name VARCHAR(100)
);

CREATE TABLE Ward (
    ward_id INT PRIMARY KEY,
    name VARCHAR(100),
    super_nurse_id INT
);

CREATE TABLE Nurse (
    nurse_number INT PRIMARY KEY,
    name VARCHAR(100),
    address VARCHAR(200),
    ward_id INT,
    FOREIGN KEY (ward_id) REFERENCES Ward(ward_id)
);

ALTER TABLE Ward 
ADD FOREIGN KEY (super_nurse_id) REFERENCES Nurse(nurse_number);

CREATE TABLE Patient (
    patient_id INT PRIMARY KEY,
    name VARCHAR(100),
    dob DATE,
    ward_id INT,
    consultant_id INT,
    FOREIGN KEY (ward_id) REFERENCES Ward(ward_id),
    FOREIGN KEY (consultant_id) REFERENCES Consultant(consultant_id)
);

CREATE TABLE Examine (
    patient_id INT,
    consultant_id INT,
    PRIMARY KEY (patient_id, consultant_id),
    FOREIGN KEY (patient_id) REFERENCES Patient(patient_id),
    FOREIGN KEY (consultant_id) REFERENCES Consultant(consultant_id)
);

CREATE TABLE Drug (
    drug_code INT PRIMARY KEY,
    recommended_dosage VARCHAR(100)
);

CREATE TABLE Drug_Brand (
    drug_code INT,
    brand_name VARCHAR(100),
    PRIMARY KEY (drug_code, brand_name),
    FOREIGN KEY (drug_code) REFERENCES Drug(drug_code)
);

CREATE TABLE Gives (
    patient_id INT,
    nurse_number INT,
    drug_code INT,
    admin_date DATE,
    admin_time TIME,
    dosage VARCHAR(100),
    PRIMARY KEY (patient_id, nurse_number, drug_code, admin_date, admin_time),
    FOREIGN KEY (patient_id) REFERENCES Patient(patient_id),
    FOREIGN KEY (nurse_number) REFERENCES Nurse(nurse_number),
    FOREIGN KEY (drug_code) REFERENCES Drug(drug_code)
);
