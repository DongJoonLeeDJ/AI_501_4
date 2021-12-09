public class Friend {
    String name;
    Company cmp;        // Null 일 가능성이 있다..
    public Friend(String name, Company cmp) {
        this.name = name;
        this.cmp = cmp;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public Company getCmp() {
        return cmp;
    }
    public void setCmp(Company cmp) {
        this.cmp = cmp;
    }
}

class Company{
    String cName;
    public Company(String cn){
        cName = cn;
    }
    public String getcName() {
        return cName;
    }
    public void setcName(String cName) {
        this.cName = cName;
    }
}
