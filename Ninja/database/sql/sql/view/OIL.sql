CREATE VIEW "OIL" (
    AS SELECT * 
    FROM PRC 
    WHERE Fund LIKE 'H%'
);