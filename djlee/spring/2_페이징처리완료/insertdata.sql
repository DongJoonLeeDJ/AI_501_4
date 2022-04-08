SELECT * FROM mymvc.book;

INSERT INTO `mymvc`.`book` (`title`, `category`, `price`) VALUES ('ㄴㅇㄻㄴㅇㅎㄻㅎㄹㄴㅇㅀㄴㅇㅀㄴㅇㅀ', 'bfbb', '550');
INSERT INTO `mymvc`.`book` (`title`, `category`, `price`) VALUES ('ㅓㅏㅓㅏㅓㅏ', 'deddd', '650');
INSERT INTO `mymvc`.`book` (`title`, `category`, `price`) VALUES ('ㅋㅋㅋㅋㅋㅋㅋㅊㅌㅍ', 'fsfff', '470');


SELECT COUNT(*) FROM book;


select  book_id, title, category, price, insert_date from book where 1 = 1 order by insert_date desc;


INSERT INTO `mymvc`.`book` (`title`, `category`, `price`) VALUES ('1푸푸푸푸푸', '티티티티티티', '5500');
INSERT INTO `mymvc`.`book` (`title`, `category`, `price`) VALUES ('2호호호호홍', '차차차차차차', '6500');
INSERT INTO `mymvc`.`book` (`title`, `category`, `price`) VALUES ('3마마마마마ㅏ', '허허허허허', '56000');
