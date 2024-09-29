CREATE TABLE Branches (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- 자동 증가하는 고유 ID
    BranchName NVARCHAR(100),          -- 지점 이름
    Location NVARCHAR(255),            -- 지점 위치 (주소 또는 지역)
    ContactNumber NVARCHAR(20),        -- 지점 연락처 번호
    EstablishedDate DATE,              -- 지점 설립일
    IsActive BIT                       -- 지점 활성 상태 (1: Active, 0: Inactive)
);