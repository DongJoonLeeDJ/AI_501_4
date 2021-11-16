
function MyStudent(n, a, nm)
{
    this.name   = n
    this.age    = a
    this.number = nm
    this.regist = function()
    {
        alert(this.name + '학생 등록 완료')
    }
}

//window - DOM객체의 일종
//DOM은 Document Object Model
//window는 우리가 웹브라우저에서 이용하는 창
//window.onload의 뜻
//body에 태그에 있는 본문들이 모두 다
//불러와졌을 경우 호출됨
window.onload = function()
{
    //head태그쪽에 적어도
    //body에 있는 내용들이 다 불러와 진 뒤에
    //적는거라 에러 없음

    let my_name = document.querySelector('#name')
    let my_age = document.querySelector('#age')
    let my_num = document.querySelector('#num')

    let my_create = document.querySelector('#create')
    let my_read   = document.querySelector('#read')
    let my_update = document.querySelector('#update')
    let my_delete = document.querySelector('#delete')
    //참고로 변수명으로 'delete' 안 됨
    //js 자체에서 delete라는 키워드를 이미 사용하고 있음
    let consolelog = document.querySelector('#consolelog')

    let students = []
    //학생추가
    my_create.onclick = function()
    {
        for(let item of students) //중복체크 및 조치
        {
            if(item.number == my_num.value)
            {
                alert("중복 학생 존재")
                return
            }
        }
        //중복이 아닌 경우 아래 코드 수행
        let tempStudent = new MyStudent(my_name.value, 
                          my_age.value, my_num.value)
        students.push(tempStudent)
        tempStudent.regist()
        console.log(students)
    }

    my_read.onclick = function()
    {
     for(let item of students)
     {
         if(my_num.value == item.number)
         {
             alert(`${item.number}번 학생은 ${item.name}이며, ${item.age}살입니다.`)
             return
         } 
     }
    }

    my_update.onclick = function()
    {
        for(let item of students)
        {
            if(my_num.value == item.number)
            {
                item.name = my_name.value
                item.age  = my_age.value
            } 
        }
    }
    my_delete.onclick = function()
    {
        for(let i = 0; i<students.length; i++)
        {
            if(my_num.value == students[i].number)
                students.splice(i,1)//i번째꺼 하나 뺀다
        }
    }

    consolelog.onclick=function()
    {
        console.log(students)
    }

}
