var o_cursor refcursor 
exec person_select('이동준', :o_cursor) 
print o_cursor 


--o_cursor이라는 refcursor 변수 선언
--o_cursor에 값저장
--o_cursor에 있는 것들 print함

--세 줄 다 드래그해서 ctrl enter해서 실행해줘야 함
