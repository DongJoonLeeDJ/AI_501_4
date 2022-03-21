import './CC.css';

export default function CC(){
    let numbers = [1,2,3,4,5];
    let cc = [
              {id:1,text:"c111",val:false},
              {id:2,text:"c222",val:true},
              {id:3,text:"c333",val:true}
            ]
    // 5개 ...
    const ultags = numbers.map((number)=> <li key={number}>{number}</li> );
    const cctags = cc.map(obj => <li key={obj.id}>{obj.text} x {obj.val && '츄루'}</li>)
    return (
        <div>
            <ul className="myul">
                {ultags}
            </ul>
            <ul className="myul">
                {cctags}
            </ul>
        </div>
    );
}
