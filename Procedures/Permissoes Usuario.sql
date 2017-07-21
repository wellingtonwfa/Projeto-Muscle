/*CREATE USER 'jeffrey'@'localhost' IDENTIFIED BY 'mypass';*/
GRANT ALL PRIVILEGES ON *.* TO 'root'@'localhost';
/*GRANT SELECT, INSERT ON localhost.* TO 'root'@'localhost';
ALTER USER 'jeffrey'@'localhost' WITH MAX_QUERIES_PER_HOUR 90;*/
flush privileges