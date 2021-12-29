create or replace procedure add_person
(
    mynum in int, --매개변수, in 키워드는 매개변수를 의미함
    myname varchar2,
    mypn varchar2
)
IS
BEGIN
    insert into simple_address_book values(mynum, myname, mypn);
END add_person;