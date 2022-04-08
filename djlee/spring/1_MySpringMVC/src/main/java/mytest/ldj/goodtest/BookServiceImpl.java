package mytest.ldj.goodtest;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

//Controller와 DAO부분을 이어주는 부분
@Service
public class BookServiceImpl implements BookService {

	@Autowired
	BookDao bookDao; //별도의 new 키워드가 없어도 자동으로 객체를 만들어서 BeanFactory에서 자동관리하고 있음
	
	@Override
	public String create(Map<String, Object> map) {
		int affectRowCount = this.bookDao.insert(map); //map객체 이용해서 insert 호출
		if(affectRowCount==1) { //생성 성공 
			System.out.println(map.toString());
			return map.get("book_id").toString();
		}
		return null;
	}
	
	@Override
	public Map<String, Object> detail(Map<String, Object> map) {
		return this.bookDao.selectDetail(map);
	}
	
	@Override
	public boolean edit(Map<String, Object> map) {
		int affectRowCount = this.bookDao.update(map);
		return affectRowCount==1; //update 성공시 true, 실패하면 false를 리턴하는 코드
	}
	
	@Override
	public boolean remove(Map<String, Object> map) {
//		int a = 10;
//		int b = 20;
//		int c = ++a + ++b; //32
//		
//		int aa = 10;
//		int bb = 20;
//		aa++; //11
//		bb++; //21
//		int cc = aa+bb; //32
		int affectRowCount = this.bookDao.delete(map);
		return affectRowCount == 1; //delete 성공시 true, 실패하면 false를 리턴
		//return this.bookDao.delete(map)==1;
	}
	
	@Override
	public List<Map<String,Object>> list(Map<String, Object> map) {
		return this.bookDao.selectList(map);
	}
	
	
}
