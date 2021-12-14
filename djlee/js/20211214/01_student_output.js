document.addEventListener('DOMContentLoaded',
function()
{
    //alert(new Student('류경문','남',1).투스트링())
    const name = document.querySelector('#name')
    const gender = document.querySelector('#gender')
    const beonho = document.querySelector('#beonho')

    const print = document.querySelector('#print')
    const reset = document.querySelector('#reset')
    const printOrderBy = 
            document.querySelector('#printOrderBy')
    const information = 
            document.querySelector('#information')

    function resetInfo()
    {
        information.innerHTML = '' //화면 리셋해주기
    }

    reset.addEventListener('click', function()
    {
        resetInfo() //화면 리셋
        students = [] //배열 리셋
    })

    print.addEventListener('click', function()
    {
        const student = new Student(name.value,
                                    gender.value,
                                    Number(beonho.value))
        let newStudentInfo = document.createElement('h1')
        newStudentInfo.textContent = student.투스트링()
        if(student.성별 == "남")
        {
            newStudentInfo.style.backgroundColor='springgreen'
            newStudentInfo.style.color = 'blue'
        }
        else
        {
            newStudentInfo.style.backgroundColor='black'
            newStudentInfo.style.color = 'pink'
        }
        information.appendChild(newStudentInfo)
        
    })

    printOrderBy.addEventListener('click', function()
    {
        //findIndex
        //indexOf랑 좀 유사한 건데... 
        //주로 객체배열에서 쓰임
        //객체 배열상에서 내가 원하는 객체의
        //인덱스를 찾는 데, 콜백함수 이용함
        //이 함수가 true 리턴하는 조건을 만족하는 
        //부분의 인덱스값 리턴해줌
        const idx = students.findIndex (
            function(item) {
                return item.번호 === Number(beonho.value)
            }
        )
        if(idx != -1)
        {
            alert('번호 중복')
            return
        }

        resetInfo() //기존에 있던 것들 싹 지움
        students.push(new Student( name.value,
                                   gender.value,
                                   Number(beonho.value)))
        //Sort
        //콜백함수 이용
        //값이 양수, 0, 음수냐에 따라서 정렬됨
        students.sort(function(a,b){
            return a.번호 - b.번호
        })

        //for(const item of students)
        for(let i = 0 ; i<students.length; i++)
        {
            let newStudentInfo = document.createElement('h1')
            newStudentInfo.textContent = students[i].투스트링()
            if(students[i].성별 == "남")
            {
                newStudentInfo.style.backgroundColor='springgreen'
                newStudentInfo.style.color = 'blue'
            }
            else
            {
                newStudentInfo.style.backgroundColor='black'
                newStudentInfo.style.color = 'pink'
            }
            information.appendChild(newStudentInfo)
        }
    })





})