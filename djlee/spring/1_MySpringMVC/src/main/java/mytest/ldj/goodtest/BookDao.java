package mytest.ldj.goodtest;

import java.util.List;
import java.util.Map;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;


//BookDao�� Bean��ü�� ���.
//�� ������ �����̳ʰ� ����
//DB���� ���õ� Bean��ü��� �ǹ̿��� 
//Repository��� �̸� ����
@Repository
public class BookDao {

	//root-context�� bean��ü�� ���ؼ� ��ü�� ������Ŵ.
	//new... ��� ���� �ʿ����. 
	@Autowired 
	SqlSessionTemplate sqlSessionTemplate;
	
	public int insert(Map<String, Object> map) {
		return this.sqlSessionTemplate.insert("book.insert", map);
	}
	
	public Map<String, Object> selectDetail(Map<String, Object> map) {
		//map�� �̿��ؼ� select_detail ȣ��.(select �±�, id=select_detail)
		return this.sqlSessionTemplate.selectOne("book.select_detail", map);
	}
	
	public int update(Map<String, Object> map) {
		return this.sqlSessionTemplate.update("book.update", map);
	}
	
	public int delete(Map<String, Object> map) {
		return this.sqlSessionTemplate.delete("book.delete", map);
	}
	
	//java.awt ���� java.util�� import�� ��
	public List<Map<String, Object>> selectList(Map<String, Object> map) {
		return this.sqlSessionTemplate.selectList("book.select_list", map);
	}
	
	
	
	
	
}

