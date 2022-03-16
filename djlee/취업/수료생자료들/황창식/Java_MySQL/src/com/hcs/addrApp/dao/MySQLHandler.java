package com.hcs.addrApp.dao;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import com.hcs.addrApp.model.AddrBook;

public class MySQLHandler {
	private Connection con;
	private static Statement state;
	private final String USER_ID = "root";
	private final String USER_PW = "1126";
	private final String DBNAME = "mydb";

	private String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	private String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	final int SELECT_ALL = 1;
	final int SELECT_NAME = 2;
	final int SELECT_AGE = 3;
	final int SELECT_TEL = 4;
	final int SELECT_ADDR = 5;
	final int SELECT_EMAIL = 6;
	final int SELECT_EXIT = 7;
	
	final int UPDATE_NAME = 1;
	final int UPDATE_AGE = 2;
	final int UPDATE_TEL = 3;
	final int UPDATE_ADDR = 4;
	final int UPDATE_EMAIL = 5;
	final int UPDATE_EXIT = 6;
	
	final int DELETE_ALL = 1;
	final int DELETE_ONE = 2;
	final int DELETE_EXIT = 3;
	
	Scanner s;

	public MySQLHandler(Scanner s) {
		this.s = s;
		connectDB();
	}

	private void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공!");
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public Statement getState() {
		return state;
	}

	public void createTable() {
		String query = "create table userInfo (id INT(10) NOT NULL AUTO_INCREMENT, name VARCHAR(10) NOT NULL, age INT(3) NOT NULL, tel VARCHAR(30) NOT NULL, address VARCHAR(40) NOT NULL, email VARCHAR(30) NULL, date DATETIME NOT NULL, PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
			System.out.println("\n추가되었습니다!");
		} catch (SQLException e) {
			/*
			 * System.out.println(e.getSQLState()); System.out.println(e.getMessage());
			 * System.out.println(e.getErrorCode());
			 * System.out.println(e.getCause().toString());
			 */
			errorMessage(e);
			// e.printStackTrace();
		}
	}

	public void deleteTable() {
		String dtQuery = "drop table userInfo";
		try {
			state.executeUpdate(dtQuery);
			System.out.println("\n삭제되었습니다!");
		} catch (SQLException e) {
			errorMessage(e);
		}
	}

	public void insertData(AddrBook addr) {
		String query2 = String.format(
				"insert into userinfo (name, age, tel, address, email, date) "
							+ "values ('%s', %d, '%s', '%s', '%s', now())",
				addr.getName(), addr.getAge(), addr.getTel(), addr.getAddress(), addr.getEmail());
		try {
			state.executeUpdate(query2);
			System.out.println("\n추가되었습니다.");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void insertRandData(AddrBook[] addrs) {
		String query = null;
		for (int i = 0; i < addrs.length; i++) {
			query = String.format(
					"insert into userinfo (name, age, tel, address, email, date) "
								+ "values ('%s', %d, '%s', '%s', '%s', now())",
					addrs[i].getName(), addrs[i].getAge(), addrs[i].getTel(), addrs[i].getAddress(), addrs[i].getEmail());
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		System.out.println("\n추가되었습니다.");
	}

	public void selectData(int menu) {
		String query = null;
		switch(menu) {
		case SELECT_ALL:
			query = "select * from userinfo";
			showData(query);
			break;
		case SELECT_NAME:
			System.out.print("\n찾으시는 데이터 이름을 입력하세요 : ");
			String name = s.next();
			query = String.format("select * from userinfo where name = '%s'", name);
			showData(query);
			break;
		case SELECT_AGE:
			System.out.print("\n찾으시는 데이터 나이를 입력하세요 : ");
			int age = s.nextInt();
			query = String.format("select * from userinfo where age = %d", age);
			showData(query);
			break;
		case SELECT_TEL:
			System.out.print("\n찾으시는 데이터 전화번호를 입력하세요 : ");
			String tel = s.next();
			query = String.format("select * from userinfo where tel = '%s'", tel);
			showData(query);
			break;
		case SELECT_ADDR:
			System.out.print("\n찾으시는 데이터 주소를 입력하세요 : ");
			String addr = s.next();
			query = String.format("select * from userinfo where address = '%s'", addr);
			showData(query);
			break;
		case SELECT_EMAIL:
			System.out.print("\n찾으시는 데이터 이메일을 입력하세요 : ");
			String email = s.next();
			query = String.format("select * from userinfo where email = '%s'", email);
			showData(query);
			break;
		case SELECT_EXIT:
			System.out.println("\n메인 메뉴로 이동합니다.");
			return;
		}
	}
	
	public static void showData(String query) {
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
//				System.out.print("\nID\t");
//				System.out.print("이름\t");
//				System.out.print("나이\t");
//				System.out.print("전화\t\t");
//				System.out.print("주소\t\t");
//				System.out.print("메일\t\t\t");
//				System.out.println("날짜");
				System.out.println("========================================================================================================");
				while (rs.next()) {
					int n = 0;
					System.out.print((n+1) + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString("date"));
					n++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public void updateData(String inputName) {
		int count = 0;
		try {
			ResultSet rs = state.executeQuery(String.format("select * from userinfo where name = '%s'", inputName));
			
			if (rs != null) {
				rs = state.getResultSet();
				System.out.print("\nID\t");
				System.out.print("이름\t");
				System.out.print("나이\t");
				System.out.print("전화\t\t");
				System.out.print("주소\t\t");
				System.out.print("메일\t\t\t");
				System.out.println("날짜");
				System.out.println("========================================================================================================");
				while (rs.next()) {
					System.out.print(rs.getString("id") + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString("date"));
					count++;
				}
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		if(count == 0) {
			System.out.println("\n일치하는 데이터가 없습니다.");
		}
		else if(count > 1) {
			System.out.print("\n수정할 데이터의 나이를 입력하세요 : ");
			int inputAge = s.nextInt();
			while(true) {
				showData(String.format("select * from userinfo where name = '%s' and age = '%d'", inputName, inputAge));
				System.out.println("---------------------");
				System.out.println("1. 이름 수정");
				System.out.println("2. 나이 수정");
				System.out.println("3. 전화 수정");
				System.out.println("4. 주소 수정");
				System.out.println("5. 이메일 수정");
				System.out.println("6. 돌아가기");
				System.out.println("---------------------");
				System.out.print("수정할 데이터의 항목을 입력하세요 : ");
				int updateNum = s.nextInt();
				String query = null;
				switch(updateNum) {
				case UPDATE_NAME:
					System.out.print("\n변경할 이름을 입력하세요 : ");
					String name = s.next();
					query = String.format("update userinfo set name = '%s' where name = '%s' and age = '%d'", name, inputName, inputAge);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_AGE:
					System.out.print("\n변경할 나이을 입력하세요 : ");
					int age = s.nextInt();
					query = String.format("update userinfo set age = '%d' where name = '%s' and age = '%d'", age, inputName, inputAge);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_TEL:
					System.out.print("\n변경할 전화번호를 입력하세요 : ");
					String tel = s.next();
					query = String.format("update userinfo set tel = '%s' where name = '%s' and age = '%d'", tel, inputName, inputAge);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_ADDR:
					System.out.print("\n변경할 주소을 입력하세요 : ");
					BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
					String addr = null;
					try {
						addr = br.readLine();
					} catch (IOException e1) {
						e1.printStackTrace();
					}
					query = String.format("update userinfo set address = '%s' where name = '%s' and age = '%d'", addr, inputName, inputAge);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_EMAIL:
					System.out.print("\n변경할 이메일을 입력하세요 : ");
					String email = s.next();
					query = String.format("update userinfo set email = '%s' where name = '%s' and age = '%d'", email, inputName, inputAge);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_EXIT:
					System.out.println("\n메인 메뉴로 돌아갑니다.");
					return;
				}
			}
		}
		else {
			while(true) {
				showData(String.format("select * from userinfo where name = '%s'", inputName));
				System.out.println("---------------------");
				System.out.println("1. 이름 수정");
				System.out.println("2. 나이 수정");
				System.out.println("3. 전화 수정");
				System.out.println("4. 주소 수정");
				System.out.println("5. 이메일 수정");
				System.out.println("6. 돌아가기");
				System.out.println("---------------------");
				System.out.print("수정할 데이터의 항목을 입력하세요 : ");
				int updateNum = s.nextInt();
				String query = null;
				switch(updateNum) {
				case UPDATE_NAME:
					System.out.print("\n변경할 이름을 입력하세요 : ");
					String name = s.next();
					query = String.format("update userinfo set name = '%s' where name = '%s'", name, inputName);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_AGE:
					System.out.print("\n변경할 나이을 입력하세요 : ");
					int age = s.nextInt();
					query = String.format("update userinfo set age = '%d' where name = '%s'", age, inputName);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_TEL:
					System.out.print("\n변경할 전화번호를 입력하세요 : ");
					String tel = s.next();
					query = String.format("update userinfo set tel = '%s' where name = '%s'", tel, inputName);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_ADDR:
					System.out.print("\n변경할 주소을 입력하세요 : ");
					BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
					String addr = null;
					try {
						addr = br.readLine();
					} catch (IOException e1) {
						e1.printStackTrace();
					}
					query = String.format("update userinfo set address = '%s' where name = '%s'", addr, inputName);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_EMAIL:
					System.out.print("\n변경할 이메일을 입력하세요 : ");
					String email = s.next();
					query = String.format("update userinfo set email = '%s' where name = '%s'", email, inputName);
					try {
						state.executeUpdate(query);
						System.out.println("\n수정되었습니다.");
					} catch (SQLException e) {
						e.printStackTrace();
					}
					break;
				case UPDATE_EXIT:
					System.out.println("\n메인 메뉴로 돌아갑니다.");
					return;
				}
			}
		}
		
	}
	
	public void deleteData(int menu) {
		String query = null;
		switch(menu) {
		case DELETE_ALL:
			query = String.format("delete from userinfo");
			try {
				state.executeUpdate(query);
				System.out.println("\n삭제되었습니다.");
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;
		case DELETE_ONE:
			System.out.print("\n삭제할 데이터의 이름을 입력하세요 : ");
			String delName = s.next();
			query = String.format("delete from userinfo where name = '%s'", delName);
			try {
				state.executeUpdate(query);
				System.out.println("\n삭제되었습니다.");
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;
		case DELETE_EXIT:
			System.out.println("\n메인 메뉴로 돌아갑니다.");
			return;
		}
	}
	
	public void errorMessage(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("\n테이블이 이미 존재합니다.");
			break;
		case 1051:
			System.out.println("\n테이블이 존재하지 않습니다.");
			break;
		case 1064:
			System.out.println("\n쿼리를 잘못 입력하셨습니다.");
			break;
		}
	}

}
