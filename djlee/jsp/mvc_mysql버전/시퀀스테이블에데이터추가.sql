call create_sequence('mvc_board');
select * from sequences;
delete from sequences;
# modifies sql data : 데이터를 쓸 수도 있는 명령문
# determinitic mysql에서 함수가 파라메터 동일하면 단 한 번만 출력(여러번 호출되도 한 번만 출력, 중복실행방지)
