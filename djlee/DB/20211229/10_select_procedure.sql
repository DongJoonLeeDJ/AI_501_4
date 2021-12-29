-- select procedure는 cursor를 반환해준다.
-- 그리고 이 cursor를 이용해서 결과를  출력
-- cursor가 뭐냐면... sql 결과를 저장하는 메모리를 가리키는 포인터
create procedure person_select
(
   myname in varchar2, --매개변수
   o_cursor out sys_refcursor --커서를 반환
)
IS
BEGIN
   open o_cursor 
   for
       select num,name,phone_number from simple_address_book 
       where name=myname;
exception 
   when others then
      dbms_output.put_line('sql error : ' || SQLERRM);
    end person_select;
  --    /를 적으면 그 밑에 코드는 프로시저랑 연관이 없게 됨

--기존의 객체가 이름을 사용하고 있습니다.
--프로시저를 지우거나
--만들 때 아예 create or replace를 붙여버림


