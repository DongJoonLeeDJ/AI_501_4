select @rownum:=@rownum+1 as no, book.* from book where (@rownum:=0)=0;
select @rownum:=@rownum+1 as no, book.* from book where (@rownum:=0)=0 limit 0,3;#<skip>,<count>  #1 2 3
select @rownum:=@rownum+1 as no, book.* from book where (@rownum:=0)=0 limit 3,3;#<skip>,<count>  #4 5 6
select @rownum:=@rownum+1 as no, book.* from book where (@rownum:=0)=0 limit 6,3;#<skip>,<count>  #4 5 6

# start 
# end
# now

# <  start가 1이면 안 됨
# >  end가 전체페이지수보다 작아야 하고, 또한 start부터 end 사이의 개수가 4인데 나타내야 하는 게 5개라면 그 때도 나타내면 안 된다.

select @rownum:=@rownum+1 as no, book_id, title, category, price, insert_date from book where 1 = 1 and (@rownum:=0)=0 order by insert_date desc ;
select @rownum:=@rownum+1 as no, book_id, title, category, price, insert_date from book where 1 = 1 and (@rownum:=0)=0 order by insert_date desc limit 0,3;
select @rownum:=@rownum+1 as no, book_id, title, category, price, insert_date from book where 1 = 1 and (@rownum:=0)=0 order by insert_date desc limit 3,3;

SELECT COUNT(*) FROM book;


select  book_id, title, category, price, insert_date from book where 1 = 1 order by insert_date desc;
select  book_id, title, category, price, insert_date from book where 1 = 1 order by insert_date desc limit 10000;
select  book_id, title, category, price, insert_date from book where 1 = 1 order by insert_date desc limit 0,3;





