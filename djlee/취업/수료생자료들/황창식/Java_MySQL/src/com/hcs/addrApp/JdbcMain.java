package com.hcs.addrApp;


import java.util.Scanner;
import com.hcs.addrApp.dao.MySQLHandler;
import com.hcs.addrApp.util.MyMenu;

public class JdbcMain {
	

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		MySQLHandler db1 = new MySQLHandler(s);
		MyMenu me = new MyMenu(s);
		
		while (true) {
			switch (me.mainMenu()) {
			case MyMenu.CREATE_TABLE:
				//System.out.println("테이블 추가 메뉴");
				db1.createTable();
				break;
			case MyMenu.DELETE_TABLE:
				//System.out.println("테이블 삭제 메뉴");
				db1.deleteTable();
				break;
			case MyMenu.CREATE_DATA:
				//System.out.println("데이터 추가 메뉴");
				db1.insertData(me.insertDataMenu());
				break;
			case MyMenu.CREATE_RAND_DATA:
				//System.out.println("랜덤 데이터 추가 메뉴");
				db1.insertRandData(me.randDateMenu());
				break;
			case MyMenu.VIEW_DATA:
				//System.out.println("데이터 보기 메뉴");
				db1.selectData(me.selectMenu());
				break;
			case MyMenu.UPDATE_DATA:
				//System.out.println("데이터 수정 메뉴");
				db1.updateData(me.updateMenu());
				break;
			case MyMenu.DELETE_DATA:
				//System.out.println("데이터 삭제 메뉴");
				db1.deleteData(me.deleteMenu());
				break;
			case MyMenu.PROGRAM_EXIT:
				db1.closeDB();
				s.close();
				System.out.println("Thanks for Using!");
				System.exit(0);
				break;
			default:
				System.out.println("\n잘못 입력하셨습니다.");
				break;
			}
		}
	}
}
