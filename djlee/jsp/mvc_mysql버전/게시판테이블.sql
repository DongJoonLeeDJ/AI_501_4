
CREATE TABLE `mvc_board` (
  `bId` int NOT NULL,
  `bName` varchar(45) DEFAULT NULL,
  `bTitle` varchar(100) DEFAULT NULL,
  `bContent` varchar(300) DEFAULT NULL,
  `bDate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `bHit` int DEFAULT '0',
  `bGroup` int DEFAULT NULL,
  `bStep` int DEFAULT NULL,
  `bIndent` int DEFAULT NULL,
  PRIMARY KEY (`bId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
