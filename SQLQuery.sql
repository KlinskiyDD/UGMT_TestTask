DECLARE @Flowers TABLE(Name nvarchar(20))
INSERT INTO @Flowers
VALUES ('Rose'),
('Tulip'),
('Daisy'),
('Forget-me-not'),
('Lilac'),
('Narcissus'),
('Camomile'),
('Lily of the valley')

SELECT TOP 8 t1.Name Name1, 
       t2.Name Name2, 
       t3.Name Name3,
       t3.Name Name4,
       t3.Name Name5
       
FROM @Flowers t1
JOIN @Flowers t2 ON t2.Name > t1.Name
JOIN @Flowers t3 ON t3.Name > t2.Name
JOIN @Flowers t4 ON t4.Name > t3.Name
JOIN @Flowers t5 ON t5.Name > t4.Name;