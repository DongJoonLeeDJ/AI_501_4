package test;

import java.util.Collection;
import java.util.HashMap;
import java.util.Map;

public class MemberDao {
	private static int key = 0;
	private static Map<Integer, MemberDto> map = new HashMap<Integer, MemberDto>(); 

	public void doInsert(MemberDto dto) {
		System.out.println("테이블안에 member 넣었다..");
		map.put(++key, dto);
	}

	public void doList() {
		Collection<MemberDto> cols = map.values();
		cols.forEach(m -> System.out.println(m) );
		
		/*
		Set<Integer> set = map.keySet();
		for(int a:set) {
			System.out.println(map.get(a));
		}
		*/
		
	}
}
