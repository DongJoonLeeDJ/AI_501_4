package com.java.org;

public class Song {
	// �뷡������ ��Ÿ���� title
	private String title;
	// �⵵
	private int year;
	// ������ 
	private String artist;
	// country
	private String country;
	public Song() {}	// �⺻������
	
	public Song(String t,int y,String a,String c) {
		title = t;
		year = y;
		artist = a;
		country = c;
	}
	//1978�� ������������ ABBA�� �θ� Dancing Queen
	public void show() {
		System.out.println("title = "+title);
		System.out.println("year = "+year);
		System.out.println("artist = "+artist);
		System.out.println("country = "+country);
	}
	
}








