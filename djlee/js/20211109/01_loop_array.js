let myarray1 = []
let myarray2 = [1,2,3,'a','aaa',myarray1]
myarray1[0] = 111 //0번째에 아무것도 없으면 111을 집어넣음
myarray1[1] = 222 //1번째에 아무것도 없으면 222를 집어넣음
//for in 반복문 - 배열의 길이만큼 반복하는 반복문
for(let i in myarray1)
    console.log(myarray1[i])
    
for(let i in myarray2)
    console.log(myarray2[i])

    let abcd = '안녕하세요'
    console.log(abcd[0]) //하 출력
    //글자의 길이 혹은 배열의 길이 출력
    console.log(abcd.length)
    console.log(myarray1.length)
    console.log(myarray2.length)