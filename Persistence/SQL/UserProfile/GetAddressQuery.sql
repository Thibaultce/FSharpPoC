SELECT 
    UserId,
    StreetName,
    StreetNumber,
    City,
    Country
FROM [User]
WHERE UserId = @ParamUserId
