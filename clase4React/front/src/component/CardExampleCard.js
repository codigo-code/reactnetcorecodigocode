import React from 'react'
import { Card, Icon, Image } from 'semantic-ui-react'



const CardExampleCard = (props) => (
  <Card>
    <Image src='/images/avatar/large/matthew.png' wrapped ui={false} />
    <Card.Content>
      <Card.Header>{props.nombre}</Card.Header>
      <Card.Meta>
        <span className='date'> Joined in 201{props.desc}</span>
      </Card.Meta>
      <Card.Description>
        {props.descmagia}
      </Card.Description>
    </Card.Content>
    <Card.Content extra>
      <a>
        <Icon name='user' />
        22 Friends
      </a>
    </Card.Content>
  </Card>
)

export default CardExampleCard
