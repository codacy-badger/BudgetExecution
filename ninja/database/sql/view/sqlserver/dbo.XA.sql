﻿CREATE VIEW "XA" 
AS SELECT * 
FROM PRC 
WHERE RC = '06X' AND Amount > 0;