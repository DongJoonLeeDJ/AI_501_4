package chap09;

public class LoginReq {

	private String email;
	private String pwd;
	
	public LoginReq(String email, String pwd) {
		super();
		this.email = email;
		this.pwd = pwd;
	}
	
	@Override
	public String toString() {
		return "LoginReq [email=" + email + ", pwd=" + pwd + "]";
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
	
	
}
