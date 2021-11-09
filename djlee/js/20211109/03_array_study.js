// 배열에 요소를 추가할 때, 
// 단순히 인덱스를 적어서 추가할 수도 있지만
// 맨 끝에 값을 추가하고 싶을 때 사용하는 방법
let aa = [1,2,'삼',4]
aa.push('오5') //맨 끝에 값을 추가함 
for(let item of aa)
    console.log(item)

aa[aa.length] = 6//맨 끝에 값 추가하는 방법2

for(let item of aa)
    console.log(item)

aa[10] = 10
console.log(aa) //[6]~[9]까지 empty가 들어감
console.log(aa.length) //길이가 11로 변함

//특정 요소를 제거하기
aa.splice(0,1) //가장 첫번째꺼 하나를 제거
console.log("----0번째꺼 지움 ----");
for(let item of aa)
    console.log(item)

aa.splice(1,3) //두번째([1]번째)부터 시작해서 3개 지움for(let item of aa)
console.log("----3개 지운 뒤 ----");
for(let item of aa)
    console.log(item)

//index(위치) 모르지만
//특정 위치에 있는 값을 지우고 싶을 때
//만약 숫자 6을 지우고 싶을 경우!
//indexOf : 특정 값의 인덱스값을 구함
const myindex = aa.indexOf(6) 
console.log("6의 위치 : "+myindex)
aa.splice(myindex,1)
console.log("----6 지운 뒤 ----");
for(let item of aa)
    console.log(item)

//특정 위치에 값 추가하기
//뭔가 추가하기 위한 splice인 경우
//두번째 매개변수(=파라메터)에 0을 집어넣자.
aa.splice(2,0,1000) //[2]번째 인덱스에 1000추가
console.log("----[2]번째에 1000추가 ----");
for(let item of aa)
    console.log(item)
