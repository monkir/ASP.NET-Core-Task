import axios from "axios";
import { useEffect, useState } from "react";

function ViewLogStatus(){
    const [data, getData] = useState();
    useEffect(()=>{
        axios.get("https://localhost:7133/api/ViewLog/ListOfViewLogStatus")
        .then((res)=>{
            getData(res.data);
            console.log(data);
        })
        .catch((error)=>{
            console.log(error);
        })
    }, [])
    
    return(
        <>
        <div>
            {/* {data.map()} */}
            <p>Say someting</p>
            <table>
                <thead>
                    <tr>
                        <th style={{border:"2px solid black"}}>serialNo</th>
                        <th style={{border:"2px solid black"}}>channelName</th>
                        <th style={{border:"2px solid black"}}>dateFrom</th>
                        <th style={{border:"2px solid black"}}>dateTo</th>
                    </tr>
                </thead>
                <tbody>
                    {data != null ? data.map(item=>(
                        <tr key={item.serialNo}>
                            <th style={{border:"2px solid black"}}>{item.serialNo}</th>
                            <td style={{border:"2px solid black"}}>{item.channelName}</td>
                            <td style={{border:"2px solid black"}}>{item.dateFrom}</td>
                            <td style={{border:"2px solid black"}}>{item.dateTo}</td>
                        </tr>
                    )): "Data is loading"}
                </tbody>
                
            </table>
        </div>
        </>
    )
}
export default ViewLogStatus;