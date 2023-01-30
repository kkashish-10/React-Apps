
import React, { useEffect } from 'react'

const HookB = () => {
    useEffect(() => {
        console.log("Mounting ...");
    });

    return (
        <div>HookB
            <h1>    Geeks ...</h1>
        </div>
    )
}

export default HookB