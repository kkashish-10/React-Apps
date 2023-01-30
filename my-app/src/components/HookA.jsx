import React, { useState } from 'react'

const HookA = () => {
    const [change, setchange] = useState(true);
    return (
        <>
            <div>HookA</div>
            <div>
                <button onClick={()=>setchange(!change)}>Click to change Text !</button>
                {change ?<h1>Welcome to React True</h1> : <h1>Welcome to React False</h1>}
            </div>
        </>

    )
}

export default HookA