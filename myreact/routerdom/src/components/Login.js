import './Login.css'
export default function Login(){
    function doSubmit(e){
        e.preventdefault();
    }
    return (<div>
        <form onSubmit={doSubmit}>
            <h3>아이디</h3> 
            <input type="text" name="id"/>
            <h3>비밀번호</h3> 
            <input type="text" name="pw"/>
            <br></br>
            <input type="button" value="로그인"/>
        </form>
    </div>)
}