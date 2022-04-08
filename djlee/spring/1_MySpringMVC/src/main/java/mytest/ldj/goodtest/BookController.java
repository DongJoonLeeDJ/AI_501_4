package mytest.ldj.goodtest;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;


//@붙은 어노테이션의 역할 : 컴파일러에게 정보를 제공
//Override가 붙으면 오버라이딩을 한다는 의미
//Depreciate가 붙으면 오래된 메소드라는 경고메시지가 뜬다.


//MVC의 Control역할을 한다.
@Controller
public class BookController {
	
	//BookService 인터페이스를 구현하고 있는 클래스에 자동으로 연결
	//즉
	//BookService bookService = new BookServiceImpl();
	@Autowired
	BookService bookService;

	@RequestMapping(value="/create", method=RequestMethod.GET)
	public ModelAndView create() { //사실 이 메소드의 이름은 중요하지 않다. /create로 들어가면 이 메소드를 호출해기 때문.
		return new ModelAndView("book/create");
	}
	
	//create부분을 POST로 접속할 경우 -> 실제 책 만들기
	@RequestMapping(value="/create", method= RequestMethod.POST)
	public ModelAndView createPost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();
		System.out.println(map.toString());
		//{title=aadj, category=bbdj, price=8764, book_id=4}
		String bookId = this.bookService.create(map);
		if(bookId==null) {
			mav.setViewName("redirect:/create");
		} else {
			mav.setViewName("redirect:/detail?bookId="+bookId); //생성한 책의 상세정보로 이동
		}
		
		return mav;
	}
	
	
	@RequestMapping(value="/detail", method= RequestMethod.GET)
	public ModelAndView detail(@RequestParam Map<String, Object> map) {
		System.out.println("detail");
		System.out.println(map);
		Map<String, Object> detailMap = this.bookService.detail(map);
		
		ModelAndView mav = new ModelAndView();
		mav.addObject("data", detailMap);
		String bookid = map.get("bookId").toString();
		mav.addObject("bookId", bookid);
		mav.setViewName("/book/detail");
		
		System.out.println("mav");
		System.out.println(mav);
		
		return mav;
	}
	
	
	@RequestMapping(value="/update", method=RequestMethod.GET)
	public ModelAndView update(@RequestParam Map<String, Object> map) {
		Map<String, Object> detailMap = this.bookService.detail(map);
		
		ModelAndView mav= new ModelAndView();
		mav.addObject("data", detailMap);
		mav.setViewName("/book/update");
		System.out.println("mav : update : GET");
		System.out.println(mav);
		return mav;
	}
	
	@RequestMapping(value="update", method=RequestMethod.POST) 
	public ModelAndView udpatePost(@RequestParam Map<String, Object> map) {
		ModelAndView mav = new ModelAndView();
		boolean isUpdateSuccess = this.bookService.edit(map);
		if(isUpdateSuccess) {
			String bookId = map.get("bookId").toString();
			mav.setViewName("redirect:/detail?bookId="+bookId);
		} else {
			mav=this.update(map);
		}
		
		return mav;
	}
	
	@RequestMapping(value="/delete", method=RequestMethod.POST)
	public ModelAndView deletePost(@RequestParam Map<String,Object> map) {
		ModelAndView mav = new ModelAndView();
		boolean isDeleteSuccess = this.bookService.remove(map);
		if(isDeleteSuccess) {
			mav.setViewName("redirect:/list");
		} else {
			String bookId = map.get("bookId").toString();
			mav.setViewName("redirect:/detail?bookId="+bookId);
		}
		return mav;
	}
	
	@RequestMapping(value="list")
	public ModelAndView list(@RequestParam Map<String, Object> map) {
		System.out.println("list");
		System.out.println(map);
		List<Map<String, Object>> list = this.bookService.list(map);
		ModelAndView mav = new ModelAndView();
		
		mav.addObject("data",list);
		
		if(map.containsKey("keyword")) {
			mav.addObject("keyword", map.get("keyword"));
		}
		
		
		mav.setViewName("/book/list");
		return mav;
	}
	
	
}







