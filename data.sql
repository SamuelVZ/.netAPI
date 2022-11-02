use nzwalks;

-- TRUNCATE walks;
-- TRUNCATE regions;
-- TRUNCATE walkdifficulty;


INSERT INTO nzwalks.regions (Id, Code, Name, Area, Lat, `Long`, Population) 
VALUES ('1', 'NRTHL', 'Northland Region', 13789, -35.3708304, 172.5717825, 194600),
('2', 'AUCK', 'Auckland Region', 4894, -36.5253207, 173.7785704, 1718982),
('3', 'WAIK', 'Waikato Region', 8970, -37.5144584, 174.5405128, 496700),
('4', 'BAYP', 'Bay Of Plenty Region', 12230, -37.5328259, 175.7642701, 345400);

INSERT INTO nzwalks.walkdifficulty(Id, Code)
VALUES ('1', 'Easy'),
('2', 'Medium'),
('3', 'Hard');

INSERT INTO walks (Id, Name, Length, WalkDifficultyId, RegionId)
VALUES ('1', 'Waiotemarama Loop Track', 1.5 , '2', '1'),
('2', 'Mt Eden Volcano Walk', 2 , '1', '2'),
('3', 'One Tree Hill Walk', 3.5 , '1', '2'),
('4', 'Lonely Bay', 1.2 , '1', '3'),
('5', 'Mt Te Aroha To Wharawhara Track Walk', 32 , '3', '4'),
('6', 'Rainbow Mountain Reserve Walk', 3.5 , '2', '4');