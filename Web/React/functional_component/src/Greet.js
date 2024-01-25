const Greet=(props)=>{
    return (<>
            <h1>avan peru {props.name}</h1>
            <h1>His age is  {props.age}</h1>
            {props.children}
    </>);
};
export default Greet