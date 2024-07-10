CREATE TABLE IF NOT EXISTS LoginInfo
(
    Id INT NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    CreatedDate  DATETIME2 NOT NULL,
    UpdatedDate  DATETIME2 NULL,
    CONSTRAINT PK_ID PRIMARY KEY (Id)
);

CREATE TABLE IF NOT EXISTS PersonalInfo
(
    Id INT NOT NULL,
    LoginInfoId INT NOT NULL,
    PhoneNumber INT NOT NULL,
    FirstName VARCHAR(255) NULL,
    LastName  VARCHAR(255) NULL,
    CreatedDate  DATETIME2 NOT NULL,
    UpdatedDate  DATETIME2 NULL,
    CONSTRAINT PK_ID PRIMARY KEY (Id),
    CONSTRAINT FK_PERSONALINFO_LOGININFO_ID FOREIGN KEY (Id)
    REFERENCES Stock (Id)
);

.save UserDatabase.db

.tables

.schema