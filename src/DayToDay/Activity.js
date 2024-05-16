import '../DayToDay/Activity.css'


function Activity({data}){
  return(
    <>
    <h2>------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------</h2>
    <table>
<thead>
  <tr>
    <th>Activity</th>
    <th>Day</th>
    <th>startTime</th>
    <th>endTime</th>
    <th>breakTime</th>
  </tr>
  </thead>
 <tbody>
  {data.map(element => (
              <tr key={element.id}>
                <td>{element.activity}</td>
                <td>{element.day}</td>
                <td>{element.startTime}</td>
                <td>{element.endTime}</td>
                <td>{element.breakTime}</td>
              </tr>
            ))}
  </tbody>
</table>
    </>
  )
}

export default Activity;