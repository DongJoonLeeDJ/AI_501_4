//window.addEventListener('load', function(){});
//document.addEventListener('DOMContentLoaded', function(){})

window.addEventListener('load',
function()
{
       //const sounds = $('audio')
       const sounds = document.querySelectorAll('audio')

       //const pads = $(".pads div")
       const pads = document.querySelectorAll('.pads div')
       
       //const visual = $('.visual')
       const visual = document.querySelector('.visual')
       
       //const title = $('.title')
       const title = document.querySelector('.title')
       const colors = ['red', 'orange', 'yellow','green',
                        'blue','plum']

        //음악 재생 끝났을 때 이벤트
        //js의 forEach
        // sounds.each(function(index, soundFile)
        // {
        //     soundFile.onended = function() {
        //         visual.text('')
        //         title.text('')
        //     }
        // })
        sounds.forEach(
            function(soundFile) {
                soundFile.onended = function() {
                    visual.innerHTML = ''
                    title.innerHTML = ''
                }
            }
        )

        // pads.each ( function(index, pad) {
        //     $(pad).on('click', function() {
        //         sounds.each(function(index, soundFile){
        //             soundFile.pause()
        //         })
        //         //내가 클릭한 부분의 사운드
        //         //ex)가장 첫번째꺼 클릭하면
        //         //1.mp3 재생
        //         if(sounds[index]){
        //             sounds[index].currentTime = 0
        //             sounds[index].play()
        //             //audio태그의 src속성의 문자열을 sound/로 짜름
        //             const strArray = 
        //             sounds[index].src.split("sound/")
        //             title.text(strArray[1])//1.mp3, 2.mp3등의 제목 찍힘
        //         }

        //         //index는 pads안에서 몇 번째 div냐...
        //         createBubbles(index)
        //     });

        // })

        pads.forEach(function(pad, index)
        {
            pad.addEventListener('click', function(){
                sounds.forEach(function(inx){
                    inx.pause()
                })
                //console.log(index)
                if(sounds[index])
                {
                    sounds[index].currentTime = 0
                    sounds[index].play()
                    const strArray = sounds[index].src.split('sound/')
                    //console.log(strArray)
                    title.innerHTML = strArray[1]
                }
                createBubbles(index)
            })
        })

        const createBubbles = function(index)
        {
            //visual.text('')
            visual.innerHTML = ''
            //const bubble = $('<div></div>')
            const bubble = document.createElement('div')
            visual.appendChild(bubble) //visual에 bubble삽입
            bubble.style.backgroundColor = colors[index]
            bubble.style.top = '300px'
            bubble.style.animation = 
            'animation 2000ms linear infinite both'
            // bubble.css('background', colors[index]).
            // css('top','300px').
            // css('animation', 
            // 'animation 2000ms linear infinite both')
        }

    
})