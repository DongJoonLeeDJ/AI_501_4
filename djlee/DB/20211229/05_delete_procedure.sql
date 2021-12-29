create or replace procedure delete_person
(
  mynum in int
)
IS
BEGIN
    delete from simple_address_book where num=mynum;
END delete_person;

