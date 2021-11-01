package com.java.org;

public class Song {
	// 노래제목을 나타내는 title
	private String title;
	// 년도
	private int year;
	// 가수명 
	private String artist;
	// country
	private String country;
	public Song() {}	// 기본생성자
	
	public Song(String t,int y,String a,String c) {
		title = t;
		year = y;
		artist = a;
		country = c;
	}
	//1978년 스웨덴국적의 ABBA가 부른 Dancing Queen
	public void show() {
		System.out.println("title = "+title);
		System.out.println("year = "+year);
		System.out.println("artist = "+artist);
		System.out.println("country = "+country);
	}
	
}








