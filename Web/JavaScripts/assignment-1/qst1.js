class BookStore{
    constructor(isbn,bookname,bookauthor,quantityofbooks,bookprice){
        this.isbn=isbn
        this.bookname=bookname
        this.bookauthor=bookauthor
        this.quantityofbooks=quantityofbooks
        this.bookprice=bookprice
 
    }
    bookDet(){
        let total=this.quantityofbooks * this.bookprice;
   console.log(`BookId:${this.isbn}\n BookName:${this.bookname}\n BookAuthor:${this.bookauthor}\n Quantity Of Books:${this.quantityofbooks}\n Total Price:${total}`);
    }
}
let book1=new BookStore(111,'Harry Potter','JK Rowling',3,450);
book1.bookDet();