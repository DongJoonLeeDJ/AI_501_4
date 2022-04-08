package mytest.ldj.goodtest;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

//Controller�� DAO�κ��� �̾��ִ� �κ�
@Service
public class BookServiceImpl implements BookService {

	@Autowired
	BookDao bookDao; //������ new Ű���尡 ��� �ڵ����� ��ü�� ���� BeanFactory���� �ڵ������ϰ� ����
	
	@Override
	public String create(Map<String, Object> map) {
		int affectRowCount = this.bookDao.insert(map); //map��ü �̿��ؼ� insert ȣ��
		if(affectRowCount==1) { //���� ���� 
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
		return affectRowCount==1; //update ������ true, �����ϸ� false�� �����ϴ� �ڵ�
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
		return affectRowCount == 1; //delete ������ true, �����ϸ� false�� ����
		//return this.bookDao.delete(map)==1;
	}
	
	@Override
	public List<Map<String,Object>> list(Map<String, Object> map) {
		return this.bookDao.selectList(map);
	}
	
	
}
