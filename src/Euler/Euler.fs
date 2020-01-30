namespace Euler

module Say =

    let hello name =
        sprintf "Hello %s" name

module Problem1 = 

    let isDivisibleBy value =
        if value % 3 = 0 || value % 5 = 0 then value
        else 0
     
    let nums = [|1 .. 999|]

    let sum = 
        nums 
        |>Array.sumBy isDivisibleBy

    let answer = 
        sprintf "sum: %i" sum

module Problem2 = 

    let rec fibNumbers (start:int[]) (limit:int) =
        let next = 
            start.[start.Length-1] + start.[start.Length-2]
        if next > limit then start
        else fibNumbers (Array.append start [|next|]) limit
    let isEven value = 
        if value % 2 = 0 then value
        else 0
    let sum = 
        fibNumbers [|1; 1|] 4000000
        |>Array.sumBy isEven

    let answer = 
        sprintf "sum: %i" sum


module Problem3 =

    let rec findFactors (num:int64)  = 
        if num = int64(1) then [|int64(1)|]
        else if num = int64(2) then [|int64(2)|]
        else if num = int64(3) then [|int64(3)|]
        else if num%int64(2)=int64(0) then
            let divisor = num/int64(2)
            Array.append [|int64(2)|] (findFactors divisor)
        else
            let mutable factor = num
            let mutable condition = true
            let mutable index:int64 = int64(3)
            let limit:int64 = 
                int64 (sqrt (float num))
            
            while condition do
                if num%index = int64(0) then 
                    factor <-index 
                    condition <-false
                else if index > limit then
                    condition <- false
                else 
                    index <- index+int64(2) 

            if index > limit then [|num|]
            else 
                let divisor = num/factor
                Array.append (findFactors divisor) (findFactors factor)
                 

    // let largestPrimeFactor num = 
    //     let mutable factors = [|1;num|]

    //     let factor = findFactor num
    //     let remainder = num/factor

module Problem4 

    let isPalindrome num = 
        let numString = 
            string num
            
        if numString.[0] = 'k' then true
        else false
