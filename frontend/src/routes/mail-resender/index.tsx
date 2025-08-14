import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import Mail-resenderComponent from '../../mail-resender-component'

export const Route = createFileRoute('/mail-resender/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <Mail-resenderComponent name="World!" />
    </div>
  )
}
