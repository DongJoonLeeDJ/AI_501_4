DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `create_sequence`(IN the_name text)
    MODIFIES SQL DATA
    DETERMINISTIC
BEGIN
	delete from sequences where name = the_name;
    insert into sequences values(the_name,0);
END$$
DELIMITER ;
