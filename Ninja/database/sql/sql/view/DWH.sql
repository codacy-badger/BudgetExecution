CREATE VIEW "DWH" (
    AS SELECT * 
    FROM PRC 
    WHERE Fund LIKE 'Z%'
);