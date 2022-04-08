DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `nextval`(the_name varchar(32)) RETURNS bigint unsigned
    MODIFIES SQL DATA
    DETERMINISTIC
BEGIN
	declare ret bigint unsigned;
    update sequences set currval = currval+1 where name = the_name; 
    select currval into ret from sequences where name=the_name limit 1;
RETURN ret;
END$$
DELIMITER ;
