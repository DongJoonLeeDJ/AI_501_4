package mytest;

import java.util.Collection;
import java.util.HashMap;
import java.util.Map;

public class MemberDao {

	private static int primarykey = 0;
	Map<Integer, MemberDto> map = new HashMap<Integer, MemberDto>();

	public void select() {
		Collection<MemberDto> col = map.values();
//		col.forEach(md -> {
//			System.out.println("조회중...");
//			System.out.println(md);
//		});
		col.forEach(md -> System.out.println(md) );
	}

	public void insert(MemberDto md) {
		map.put(++primarykey, md);
	}
	
	public void update(int pri,MemberDto md) {
		
	}
}
