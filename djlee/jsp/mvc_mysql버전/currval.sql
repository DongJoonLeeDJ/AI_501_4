DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `currval`(the_name varchar(32)) RETURNS bigint unsigned
    MODIFIES SQL DATA
    DETERMINISTIC
BEGIN
	declare ret bigint unsigned;
    select ifnull(max(currval),1) into ret from sequences where name = the_name limit 1;
	RETURN ret;
END$$
DELIMITER ;
