﻿CREATE VIEW "TRAVEL" 
AS SELECT * 
FROM PRC 
WHERE BOC LIKE '2%' AND Amount > 0;