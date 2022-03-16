package com.hcs.addrApp.util;

import com.hcs.addrApp.model.AddrBook;

public class RandData {
	private static String[] lastName = { "김", "이", "박", "최", "강" };
	private static String[] firstName1 = { "춘", "덕", "광", "미", "용" };
	private static String[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙", "식" };
	private static String[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
	private static String[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
	private static String[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };
	
	public String getRandName() {
		return lastName[(int)(Math.random()*lastName.length)] + 
				firstName1[(int)(Math.random()*firstName1.length)] + 
				firstName2[(int)(Math.random()*firstName2.length)];
	}
	
	public int getRandAge() {
		return (int)((Math.random()*290)+10);
	}
	
	public String getRandTel() {
		return "010-" + (int)((Math.random()*8999)+1000) + "-" + (int)((Math.random()*8999)+1000); 
	}
	
	public String getRandAddr() {
		return address[(int)(Math.random()*address.length)];
	}
	
	public String getRandEmail() {
		return emailId[(int)(Math.random()*emailId.length)] + emailadd[(int)(Math.random()*emailadd.length)];
	}
	
	public AddrBook getRandddrBook() {
		return new AddrBook(getRandName(), getRandAge(), getRandTel(), getRandAddr(), getRandEmail());
	}
}
