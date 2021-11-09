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

//특정 요소를 추가(특정 위치에)