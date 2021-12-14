$(
function()
{
    //alert(new Student('류경문','남',1).투스트링())
    //모든 코드 한 번에 변경 ctrl+f2
    const name = $('#name')
    const gender = $('#gender')
    const beonho = $('#beonho')

    const print = $('#print')
    const reset = $('#reset')
    const printOrderBy = $('#printOrderBy')
    const information = $('#information')

    function resetInfo()
    {
        //information.innerHTML = '' //화면 리셋해주기
        information.html('')
    }

    reset.on('click', function()
    {
        resetInfo() //화면 리셋
        students = [] //배열 리셋
    })

    print.on('click', function()
    {
        const student = new Student(name.val(),
                                    gender.val(),
                                    Number(beonho.val()))
        let newStudentInfo = $('<h1></h1>')
        newStudentInfo.text(student.투스트링())
        if(student.성별 == "남")
        {
            newStudentInfo
            .css('background-color','springgreen')
            .css('color', 'blue')
            //newStudentInfo.style.backgroundColor='springgreen'
            //newStudentInfo.style.color = 'blue'
        }
        else
        {
            newStudentInfo
            .css('background-color','black')
            .css('color', 'pink')
            //newStudentInfo.style.backgroundColor='black'
            //newStudentInfo.style.color = 'pink'
        }
        information.append(newStudentInfo)
        
    })

    printOrderBy.on('click', function()
    {
        const idx = students.findIndex (
            function(item) {
                return item.번호 === Number(beonho.val())
            }
        )
        if(idx != -1)
        {
            alert('번호 중복')
            return
        }

        resetInfo() //기존에 있던 것들 싹 지움
        students.push(new Student( name.val(),
                                   gender.val(),
                                   Number(beonho.val())))
        //Sort
        //콜백함수 이용
        //값이 양수, 0, 음수냐에 따라서 정렬됨
        students.sort(function(a,b){
            return a.번호 - b.번호
        })

        //for(const item of students)
        for(let i = 0 ; i<students.length; i++)
        {
            let newStudentInfo = $('<h1></h1>')
            newStudentInfo.text(students[i].투스트링())
            if(students[i].성별 == "남")
            {
                newStudentInfo
                .css('background-color','springgreen')
                .css('color', 'blue')
            }
            else
            {
                newStudentInfo
                .css('background-color','black')
                .css('color', 'pink')
            }
            information.append(newStudentInfo)
        }
    })
})