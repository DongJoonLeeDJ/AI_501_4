package mysample.myspring.kordj;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class BookServiceImpl implements BookService {
	@Autowired
	BookDao bookDao;

	@Override
	public String create(Map<String, Object> map) {
		int affectRowCount = this.bookDao.insert(map);
		if (affectRowCount == 1) {
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
		return affectRowCount == 1; // 수정의 경우 입력과는 다르게 PK를 가져오거나 하는 절차가 필요없으므로 그저 1개의 행이 제대로 영향받았는지만 검사하면 된다.

	}

	@Override
	public boolean remove(Map<String, Object> map) {
		int affectRowCount = this.bookDao.delete(map);
		return affectRowCount == 1; // 삭제의 경우 수정과 동일하게 한개의 행이 제대로 영향받았는지만 검사하면 된다.

	}

	@Override
	public List<Map<String, Object>> list(Map<String, Object> map) {
		return this.bookDao.selectList(map);
	}
	
	@Override
	public int countBookBoard(Map<String, Object> map) {
		return this.bookDao.countBookBoard(map);
	}

}
