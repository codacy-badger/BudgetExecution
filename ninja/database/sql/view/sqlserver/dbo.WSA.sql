﻿CREATE VIEW "WSA" 
AS SELECT * 
FROM PRC 
WHERE RC = '06N' AND Amount > 0;