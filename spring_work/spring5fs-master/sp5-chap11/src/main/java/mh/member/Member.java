package mh.member;

public class Member {
	
	private int idx;
	private String email;
	private String pwd;
	private String gender;
	private String wdate;
	
	public Member() {}
	public Member(int idx, String email, String pwd, String gender, String wdate) {
		super();
		this.idx = idx;
		this.email = email;
		this.pwd = pwd;
		this.gender = gender;
		this.wdate = wdate;
	}
	@Override
	public String toString() {
		return "Member [idx=" + idx + ", email=" + email + ", pwd=" + pwd + ", gender=" + gender + ", wdate=" + wdate
				+ "]";
	}
	public String getWdate() {
		return wdate;
	}
	public void setWdate(String wdate) {
		this.wdate = wdate;
	}
	public int getIdx() {
		return idx;
	}
	public void setIdx(int idx) {
		this.idx = idx;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getPwd() {
		return pwd;
	}
	public void setPwd(String pwd) {
		this.pwd = pwd;
	}
	public String getGender() {
		return gender;
	}
	public void setGender(String gender) {
		this.gender = gender;
	}
	
	
	

}
