 package mysample.myspring.kordj;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

//MVC에서 Controller 역할을 하는 클래스라는 명시
//주소창에 create를 치면 book 폴더의 create를 반환함
@Controller
public class BookController {

	@Autowired
	BookService bookService;

	// rest
	// restful
	// get 방식으로 접근한다고 알려주는 것
	// 브라우저 주소가 /create일 때 실행되는 자바 컨트롤러 메소드를 작성한다. 아래 코드를 BookController 클래스에 추가한다.
	// create 메소드는 브라우저에서 /create 주소가 GET방식으로 입력되었을 때 book/create 경로의 뷰를 보여준다.
	// get 방식으로 접근시 이걸 수행
	@RequestMapping(value = "/create", method = RequestMethod.GET)
	public ModelAndView create() {
		System.out.println("create");
		return new ModelAndView("book/create");
	}

//	post 방식으로 접근시 이걸 수행
	@RequestMapping(value = "/create", method = RequestMethod.POST)
	public ModelAndView createPost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();

		String bookId = this.bookService.create(map);
		if (bookId == null) {
			mav.setViewName("redirect:/create");
		} else {
			mav.setViewName("redirect:/detail?bookId=" + bookId);
		}

		return mav;
	}

	@RequestMapping(value = "/detail", method = RequestMethod.GET)
	public ModelAndView detail(@RequestParam Map<String, Object> map) {
		Map<String, Object> detailMap = this.bookService.detail(map);

		ModelAndView mav = new ModelAndView();
		mav.addObject("data", detailMap);
		String bookId = map.get("bookId").toString();
		mav.addObject("bookId", bookId);
		mav.setViewName("/book/detail");
		return mav;
	}

	@RequestMapping(value = "/update", method = RequestMethod.GET)
	public ModelAndView update(@RequestParam Map<String, Object> map) {
		Map<String, Object> detailMap = this.bookService.detail(map);

		ModelAndView mav = new ModelAndView();
		mav.addObject("data", detailMap);
		mav.setViewName("/book/update");
		return mav;
	}

	// 실제 수정하는 부분
	@RequestMapping(value = "update", method = RequestMethod.POST)
	public ModelAndView updatePost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();

		boolean isUpdateSuccess = this.bookService.edit(map);
		if (isUpdateSuccess) {
			String bookId = map.get("bookId").toString();
			mav.setViewName("redirect:/detail?bookId=" + bookId);
		} else {
			mav = this.update(map); // 만약 갱신이 안 되었을 경우 GET 메소드로 리다이렉트하는 방법도 있겠지만, 갱신 화면을 바로 다시 보여줄 수도 있다.
		}

		return mav;
	}

	@RequestMapping(value = "/delete", method = RequestMethod.POST)
	public ModelAndView deletePost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();

		boolean isDeleteSuccess = this.bookService.remove(map); // 삭제가 성공했는지 확인한다.
		if (isDeleteSuccess) {
			mav.setViewName("redirect:/list"); // 삭제가 성공했으면 상세 페이지가 없으므로 목록으로 리다이렉트한다.
		} else {
			String bookId = map.get("bookId").toString(); // 삭제가 실패했으면 다시 상세 페이지로 이동한다.
			mav.setViewName("redirect:/detail?bookId=" + bookId);
		}

		return mav;
	}

	@RequestMapping(value = "list")
	public ModelAndView list(@RequestParam Map<String, Object> map, @RequestParam(value="nowPage", required=false)String nowPage) {

		double CNT = 3.0;
		int LIMITCNT = (int)CNT;
		ModelAndView mav = new ModelAndView();
		if(nowPage!=null)
		{
			int now = Integer.parseInt(nowPage);
			int skipCount = 0;
			if(now>1)
				skipCount = (now-1)*LIMITCNT;
				//skipCount = ((int)((Math.ceil((now/CNT)))-1)   *   LIMITCNT);			
			
			
			map.put("skipCount", skipCount);
		}
		else
		{
			map.put("skipCount", 0);
		}
		
		//map에 nowPage 값을 집어넣음. 이걸 가지고 limit 쿼리에 변수 넣음
		List<Map<String, Object>> list = this.bookService.list(map);
		System.out.println("list="+list);

		int totalcount =  (int) Math.ceil(this.bookService.countBookBoard()/CNT);
		mav.addObject("data", list);
		
		mav.addObject("totalcount", totalcount); //맨 끝 페이지 정보
		int nowPos = nowPage == null ? 1 : Integer.parseInt(nowPage);
		if(nowPos<=0)
			nowPos=1;
		mav.addObject("nowPage", nowPos); //현재 페이지 정보
		
		int endPage = (int)(Math.ceil( nowPos/CNT)*(LIMITCNT) );
		int startPage = 0;
		if(endPage > totalcount) //끝부분... 
		{
			startPage = endPage-(LIMITCNT)+1;
			endPage = totalcount;
		}
		else
		{
			startPage = endPage-(LIMITCNT)+1;
		}
		if(startPage<=0)
			startPage=1;
		
		
		mav.addObject("startPage",startPage); //현재 그룹의 시작 페이지
		mav.addObject("endPage", endPage); //현재 그룹의 끝 페이지
		
		
		
		
		//System.out.println(map);
		//System.out.println(list);
		
		//추가
		if (map.containsKey("keyword")) {  
			mav.addObject("keyword", map.get("keyword"));  
		}  

		System.out.println("---mav---");
		System.out.println("map.get(nowPage)="+nowPage);
		System.out.println(mav); 
		System.out.println("---mav---");
		mav.setViewName("/book/list");
		return mav;
	}

}
