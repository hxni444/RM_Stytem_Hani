import { useState,useEffect } from "react";
import axios from "axios"
const BookFn = (e) => {
    const [books,setBooks] = useState([])
    // const [bookid,setBookid] = useState(0)
    // const [bookName,setBookName] = useState("")
    // const [price,setPrice] = useState(0)
    // const [author,setAuthor] = useState('')
    // const[ lang,setLang] = useState('')
    // const[ date,setDate] = useState('')
    useEffect(()=>{
        axios.get("")
                .then((response)=>{
                    setBooks(response.data)
                })
    })

    return(
        <di>
            <div
                class="table-responsive"
            >
                <table
                    class="table table-primary"
                >
                    <thead>
                        <tr>
                            <th scope="col">Book id</th>
                            <th scope="col">Book Name</th>
                            <th scope="col">Price</th>
                            <th scope="col">Author</th>
                            <th scope="col">Languge</th>
                            <th scope="col">Release Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            books.map(i=>{
                                return(
                                    <tr class="">
                                    
                                <td>{i.BookId}</td>
                                <td>{i.BookName}</td>
                                <td>{i.Price}</td>
                                <td>{i.Author}</td>
                                <td>{i.ReleaseDate}</td>

                                
                                 </tr>
                                )
                                    

                                

                            })
                        }
                        
                    
                    </tbody>
                </table>
            </div>
            
        </di>
       
    
    );





     
};