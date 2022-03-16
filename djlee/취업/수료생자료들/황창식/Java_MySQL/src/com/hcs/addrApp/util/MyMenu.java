package com.hcs.addrApp.util;


import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

import com.hcs.addrApp.dao.MySQLHandler;
import com.hcs.addrApp.model.AddrBook;

public class MyMenu {
	public static final int CREATE_TABLE = 1;
	public static final int DELETE_TABLE = 2;
	public static final int CREATE_DATA = 3;
	public static final int CREATE_RAND_DATA = 4;
	public static final int VIEW_DATA = 5;
	public static final int UPDATE_DATA = 6;
	public static final int DELETE_DATA = 7;
	public static final int PROGRAM_EXIT = 8;
	
	
	BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	Scanner s;
	
	public MyMenu(Scanner s) {
		this.s = s;
	}
	
	public int mainMenu() {
		System.out.println("\n---------------------");
		System.out.println("MySQL 관리 프로그램 v1.0");
		System.out.println("---------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 랜덤 데이터 추가");
		System.out.println("5. 데이터 보기");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 종료");
		System.out.println("---------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}

	public AddrBook insertDataMenu() {
		System.out.println("\n---------------------");
		System.out.println("       데이터 추가 ");
		System.out.println("---------------------");
		System.out.print("이름 입력 : ");
		String name = s.next();
		System.out.print("나이 입력 : ");
		int age = s.nextInt();
		System.out.print("전화 입력 : ");
		String tel = s.next();
		System.out.print("주소 입력 : ");
		String addr = null;
		try {
			addr = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print("메일 입력 : ");
		String email = s.next();
		return new AddrBook(name, age, tel, addr, email);
	}
	
	public AddrBook[] randDateMenu() {
		System.out.println("\n---------------------");
		System.out.println("     랜덤 데이터 추가 ");
		System.out.println("---------------------");
		System.out.print("수량 입력 : ");
		int count = s.nextInt();
		AddrBook[] addrs = new AddrBook[count];
		for (int i = 0; i < addrs.length; i++) {
			addrs[i] = new RandData().getRandddrBook();
		}
		return addrs;
	}

	public int selectMenu() {
		System.out.println("\n---------------------");
		System.out.println("     데이터 탐색 메뉴");
		System.out.println("---------------------");
		System.out.println("1. 전체 보기");
		System.out.println("2. 이름으로 검색");
		System.out.println("3. 나이로 검색");
		System.out.println("4. 전화번호로 검색");
		System.out.println("5. 주소로 검색");
		System.out.println("6. 이메일로 검색");
		System.out.println("7. 돌아가기");
		System.out.println("---------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}
	
	public String updateMenu() {
		MySQLHandler.showData("select * from userinfo");
		System.out.println("\n---------------------");
		System.out.println("     데이터 수정 메뉴");
		System.out.println("---------------------");
		System.out.print("수정할 데이터의 이름을 입력하세요 : ");
		return s.next(); 
	}
	
	public int deleteMenu() {
		MySQLHandler.showData("select * from userinfo");
		System.out.println("\n---------------------");
		System.out.println("     데이터 삭제 메뉴");
		System.out.println("---------------------");
		System.out.println("1. 전체 삭제");
		System.out.println("2. 이름으로 검색하여 삭제");
		System.out.println("3. 돌아가기");
		System.out.println("---------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}
	
}